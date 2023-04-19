//biblioteke koje koristimo
#include <math.h>
#include <stdio.h>
#include <ThreeWire.h>  
#include <RtcDS1302.h>
#include<DHT.h>
#include <AccelStepper.h>


ThreeWire myWire(4,5,2); // IO, SCLK, CE
RtcDS1302<ThreeWire> Rtc(myWire);

//deklaracija varijabli
float UTHours=0, UTMinutes=0, UTSeconds=30;
float Lat=44.8785, Lon=18.4276, TZ = 0;
int year=0,month=0,day=0; 
int num=1;
int fan_status=0;
int received;
char key[2]={fma};
int value;
int fan;

//#define dhtpin A0
#define motorPin1  8    // IN1 on the ULN2003 driver
#define motorPin2  9    // IN2 on the ULN2003 driver
#define motorPin3  10   // IN3 on the ULN2003 driver
#define motorPin4  11   // IN4 on the ULN2003 driver
#define STEPS_PER_REV 2048
AccelStepper stepper(AccelStepper::FULL4WIRE, motorPin1, motorPin3, motorPin2, motorPin4);
#define DHTPIN 13     // Digital pin connected to the DHT sensor
#define DHTTYPE DHT11   // DHT 11
DHT dht(DHTPIN, DHTTYPE);
#define relej 7


void setup () 
{
    Serial.begin(9600,SERIAL_8N1);
    stepper.setMaxSpeed(2000.0);
    stepper.setAcceleration(1000.0);
    pinMode(relej,OUTPUT);
    digitalWrite(relej,LOW);
    dht.begin();

    Rtc.Begin();
    RtcDateTime compiled = RtcDateTime(__DATE__, __TIME__);
    printDateTime(compiled);
}
#define countof(a) (sizeof(a) / sizeof(a[0]))

 
  //critical time 

   void printDateTime(const RtcDateTime& dt)
{
    char datestring[20];

    snprintf_P(datestring, 
            countof(datestring),
            PSTR("%02u/%02u/%04u %02u:%02u:%02u"),
            dt.Month(),
            dt.Day(),
            dt.Year(),
            dt.Hour(),
            dt.Minute(),
            dt.Second() );
    Serial.print(datestring);
    UTHours=dt.Hour();
    UTMinutes=dt.Minute();
    year=dt.Year();
    month=dt.Month();
    day=dt.Day();
}

 // get position

 void get_sun_pos(float latitude, float longitude, float *altitude, float *azimuth){

	float zenith;
	float pi =3.14159265358979323;
	float twopi=(2*pi);
	float rad=(pi/180);
	float EarthMeanRadius=6371.01;	// In km
	float AstronomicalUnit=149597890.;	// In km
	float DecimalHours = UTHours + (UTMinutes + UTSeconds / 60.0 ) / 60.0;
	long liAux1 =(month-14)/12;
	long liAux2=(1461*(year + 4800 + liAux1))/4 + (367*(month - 2-12*liAux1))/12- (3*(year + 4900 + liAux1)/100)/4+day-32075;
	float JulianDate=(liAux2)-0.5+ DecimalHours/24.0;
	float ElapsedJulianDays = JulianDate-2451545.0;
	float Omega=2.1429-0.0010394594*ElapsedJulianDays;
	float MeanLongitude = 4.8950630+ 0.017202791698*ElapsedJulianDays; // Radians
	float MeanAnomaly = 6.2400600+ 0.0172019699*ElapsedJulianDays;
	float EclipticLongitude = MeanLongitude + 0.03341607*sin( MeanAnomaly ) + 0.00034894*sin( 2*MeanAnomaly )-0.0001134 -0.0000203*sin(Omega);
	float EclipticObliquity = 0.4090928 - 6.2140e-9*ElapsedJulianDays +0.0000396*cos(Omega);
	float Sin_EclipticLongitude= sin( EclipticLongitude );
	float Y = cos( EclipticObliquity ) * Sin_EclipticLongitude;
	float X = cos( EclipticLongitude );
	float RightAscension = atan2( Y, X );
	if ( RightAscension < 0.0 ) RightAscension = RightAscension + twopi;
	float Declination = asin( sin( EclipticObliquity )* Sin_EclipticLongitude );
	float GreenwichMeanSiderealTime = 6.6974243242 + 0.0657098283*ElapsedJulianDays + DecimalHours;
	float LocalMeanSiderealTime = (GreenwichMeanSiderealTime*15 + longitude)*rad;
	float HourAngle = LocalMeanSiderealTime - RightAscension;
	float LatitudeInRadians = latitude*rad;
	float Cos_Latitude = cos( LatitudeInRadians );
	float Sin_Latitude = sin( LatitudeInRadians );
	float Cos_HourAngle= cos( HourAngle );
	float UTSunCoordinatesZenithAngle = (acos( Cos_Latitude*Cos_HourAngle*cos(Declination) + sin( Declination )*Sin_Latitude));
	Y = -sin( HourAngle );
	X = tan( Declination )*Cos_Latitude - Sin_Latitude*Cos_HourAngle;
	float UTSunCoordinatesAzimuth = atan2( Y, X );
	if ( UTSunCoordinatesAzimuth < 0.0 )
		UTSunCoordinatesAzimuth = UTSunCoordinatesAzimuth + twopi;
	UTSunCoordinatesAzimuth = UTSunCoordinatesAzimuth/rad;
	float Parallax=(EarthMeanRadius/AstronomicalUnit)*sin(UTSunCoordinatesZenithAngle);
	UTSunCoordinatesZenithAngle=(UTSunCoordinatesZenithAngle + Parallax)/rad;
	*azimuth=UTSunCoordinatesAzimuth;
	zenith=UTSunCoordinatesZenithAngle;
	*altitude=90.-UTSunCoordinatesZenithAngle;
}


void loop () 
{

  // temperature 
   float dummy=dht.readTemperature();
  float temperature = dht.readTemperature();

  // Read humidity
  dummy=dht.readHumidity();
  float humidity = dht.readHumidity();
  
  if (temperature >30 || humidity >80)
  {
    digitalWrite(relej,HIGH);
    delay(5000);
    fan_status=1;
    
  }
  else 
  {
    digitalWrite(relej,LOW);
    fan_status=0;
  }
 
  


// position and time

    RtcDateTime now = Rtc.GetDateTime();
    delay(5000); // five seconds
    float alt ,az; 

//upsends values to program    

    get_sun_pos(Lat, Lon, &alt, &az);
    Serial.print(alt);
    Serial.print("*");
    Serial.print(az);
    Serial.print("*");
    Serial.print(stepper.currentPosition());
    Serial.print("*");
    Serial.print(temperature);
    Serial.print("*");
    Serial.print(humidity);
    Serial.print("*");
    Serial.print(fan_status);
    Serial.println(" ");
 
//servo

  float elevation = alt;
  
  // Calculate target position based on elevation
  float stepsPerDegree = STEPS_PER_REV / 360.0;
  float targetPosition = elevation * stepsPerDegree;


  float targetPosition_val=targetPosition-30;
  stepper.moveTo(targetPosition_val);
  while (stepper.distanceToGo() != 0) {
    stepper.runToPosition();
    stepper.runSpeedToPosition();
  }


if(key=='113')
{
  int value;
stepper.moveTo(value);
  while (stepper.distanceToGo() != 0) {
    stepper.runToPosition();
    stepper.runSpeedToPosition();
  }
  if(fan=='114')
  {
    digitalWrite(relej,HIGH);
    delay(20000);
    digitalWrite(relej,LOW);
  }
  if(fan=='115')
  {
    digitalWrite(relej,LOW);
  }
} 
}



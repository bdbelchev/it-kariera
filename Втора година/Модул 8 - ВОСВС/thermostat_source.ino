#include <LiquidCrystal.h>

#include <DHT.h>

#define LCD_CONTRAST 12
#define DHTPIN 13
#define RELAYPIN 39
#define BTN1 2
#define BTN2 3

LiquidCrystal lcd(42, 43, 53, 50, 49, 46);
DHT dht(DHTPIN, DHT22);

int targetTemp = 20;
const int hysteresis = 1;
static unsigned long last_interrupt_time = 0;

void setup()
{
  pinMode(RELAYPIN, OUTPUT);
  pinMode(LCD_CONTRAST, OUTPUT);
  pinMode(BTN1, INPUT_PULLUP);
  pinMode(BTN2, INPUT_PULLUP);
  analogWrite(LCD_CONTRAST, 15);
  Serial.begin(9600);
  lcd.begin(16, 2);
  dht.begin();

  attachInterrupt(digitalPinToInterrupt(BTN1), RaiseTemp, RISING);
  attachInterrupt(digitalPinToInterrupt(BTN2), LowerTemp, RISING);
}

void loop()
{
  UpdateTemp();
  delay(3000);
}

void UpdateTemp()
{
  int temp = dht.readTemperature();
  Serial.println(temp);
  lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("Temp: ");
  lcd.print(temp);
  lcd.print(" Set: ");
  lcd.print(targetTemp);

  if (temp < targetTemp - hysteresis)
  {
    digitalWrite(RELAYPIN, HIGH);
    Serial.println("Relay on!");
  }
  else if (temp > targetTemp)
  {
    digitalWrite(RELAYPIN, LOW);
    Serial.println("Relay off!");
  }
}

void RaiseTemp()
{
  unsigned long interrupt_time = millis();
  if (interrupt_time - last_interrupt_time > 300)
  {
    targetTemp++;
    UpdateTemp();
  }
  last_interrupt_time = interrupt_time;
}

void LowerTemp()
{
  unsigned long interrupt_time = millis();
  if (interrupt_time - last_interrupt_time > 300)
  {
    targetTemp--;
    UpdateTemp();
  }
  last_interrupt_time = interrupt_time;
}

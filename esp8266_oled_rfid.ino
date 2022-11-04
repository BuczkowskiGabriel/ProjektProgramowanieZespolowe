#include<ESP8266WiFi.h>
//#include<Wire.h>
//#include<U8g2lib.h>
#include <SPI.h>
#include <MFRC522.h>
#define BAUDRATE 115200

#define SS_PIN D8
#define RST_PIN D4
MFRC522 mfrc522(SS_PIN, RST_PIN);   //new MFRC522 instance.

const char* ssid = "AndroidTom";
const char* pass = "jodi1979";

//U8G2_SSD1306_128X32_UNIVISION_F_HW_I2C u8g2(U8G2_R0, U8X8_PIN_NONE);
//U8G2_SSD1306_128X64_NONAME_F_HW_I2C u8g2(U8G2_R0, U8X8_PIN_NONE);

//#define ROW_1 8
//#define ROW_2 18
//#define ROW_3 28

//#define COL_START 0

void setup() {
Serial.begin(BAUDRATE);
WiFi.begin(ssid,pass);
Serial.print("Connecting to "); Serial.print(ssid); Serial.print("with password "); Serial.println(pass);
Serial.print("Start connection .");
//while(WiFi.status()!=WL_CONNECTED) {
//  delay(500);
//  Serial.print("."); }
//Serial.print("ESP8266 board IP "); Serial.print(WiFi.localIP());

SPI.begin();             
mfrc522.PCD_Init();
/*
Wire.begin();
u8g2.begin();
u8g2.clearBuffer();
u8g2.clearDisplay();
u8g2.setFont(u8g2_font_ncenB08_tr); // choose a suitable font
u8g2.setCursor(COL_START, ROW_1);
u8g2.print("IP "); u8g2.print(WiFi.localIP()); 
u8g2.sendBuffer();*/
}

String tag_uid = "";
byte number;

void loop() {
//u8g2.setCursor(COL_START, ROW_2);
//String message = F("RFID Reader");
//u8g2.print(message); 
//u8g2.sendBuffer();+


while(1) {
  
  if(!mfrc522.PICC_IsNewCardPresent()) return;
  if(!mfrc522.PICC_ReadCardSerial()) return;
  tag_uid = "";
  Serial.print("UID ");
  
  for(int i = 0; i < (int)mfrc522.uid.size; i++) {
    Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0 " : " ");
    Serial.print(mfrc522.uid.uidByte[i], HEX);
    tag_uid+=String(mfrc522.uid.uidByte[i], HEX);}
    delay(300);
/*    
    u8g2.setCursor(COL_START, ROW_3);
    u8g2.print("       ");
    u8g2.sendBuffer();
    u8g2.setCursor(COL_START, ROW_3);
    u8g2.print(tag_uid); 
    u8g2.sendBuffer();
    if (tag_uid == "3a7a2a83") {
      Serial.println("\nTag identification correct");
    } else {
      Serial.println("\nUnknown tag");
  }
  */
}
}

//test #define ANALOG_IN 0
#define FASTADC 1

#ifndef cbi
#define cbi(sfr, bit) (_SFR_BYTE(sfr) &= ~_BV(bit))
#endif
#ifndef sbi
#define sbi(sfr, bit) (_SFR_BYTE(sfr) |= _BV(bit))
#endif

void setup() {
  
  #if FASTADC
 // set prescale to 16
 sbi(ADCSRA,ADPS2) ;
 cbi(ADCSRA,ADPS1) ;
 cbi(ADCSRA,ADPS0) ;
#endif

  Serial.begin(250000);
  }
  
void loop() {
 
  int loval;
  int hival;
  int val = analogRead(ANALOG_IN);

  hival = ( (val >> 8) | ( val & 0x80) >> 3) | 0x80;
  loval = (val & 0x7f);

  Serial.write( hival & 0xff );
  Serial.write( loval & 0xff );
}

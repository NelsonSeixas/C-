int dadosMonitor;


void setup() {
  
  Serial.begin(9600);
  pinMode(13, OUTPUT);
}
void loop() {
  
  if (Serial.available()) {
    dadosMonitor = Serial.read();
    // String tete = (String)dadosMonitor;
    char teste = (char)dadosMonitor;
    if (dadosMonitor == 'A' || dadosMonitor == 'a') {
      Serial.print(teste);
      Serial.println(" - Ligado");
      digitalWrite(13, HIGH);
    }
    else {
      digitalWrite(13, LOW);
      Serial.print(teste);
      Serial.println(" - Desligado");
    }
  }
}


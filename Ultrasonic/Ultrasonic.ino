#define trigPin 11

#define echoPin 12

#define led 13

void setup()

{ Serial.begin (9600);

pinMode(trigPin, OUTPUT);

pinMode(echoPin, INPUT);

pinMode(led, OUTPUT);

}

void loop()

{ long duration, distance;

digitalWrite(trigPin, LOW);

delayMicroseconds(2);

digitalWrite(trigPin, HIGH);

delayMicroseconds(10);

digitalWrite(trigPin, LOW);

duration = pulseIn(echoPin, HIGH);

distance = (duration/2) / 29.1;

if (distance < 50)

{ digitalWrite(led,HIGH);
Serial.println("Run");

}

else{

digitalWrite(led,LOW);

Serial.println("Stop");

}

delay(300);

}

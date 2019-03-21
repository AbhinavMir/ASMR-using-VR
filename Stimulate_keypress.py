from pynput.keyboard import Key, Controller
import time
import serial
ser=serial.Serial("COM8",9600)
keyboard= Controller()
while(True):
    x=(ser.readline()).strip().decode()
    print(x)
    if(x=='Run'):
        keyboard.press('w')
    else:
        keyboard.release('w')

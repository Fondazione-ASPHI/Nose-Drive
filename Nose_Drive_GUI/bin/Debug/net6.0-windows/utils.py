import sys
import time
import pynput
from pynput.keyboard import Key
from pynput.mouse import Button
keyboard = pynput.keyboard.Controller()
mouse = pynput.mouse.Controller()

if sys.argv[1] == "keypress":
    print("Pressing pause key", file=sys.stderr)
    keyboard.press(str(sys.argv[2]))
    time.sleep(0.1)
    keyboard.release(str(sys.argv[2]))

import pynput
from pynput.keyboard import Key
from pynput.mouse import Button
keyboard = pynput.keyboard.Controller()
mouse = pynput.mouse.Controller()


#################
# CUSTOM LOGIC #
#################
while True:

  # Convert KEYBOARD to Controller (for Vocal Commands)
  if keyboard.is_pressed('space'):
    keyboard.press(Key.up)
    keyboard.release(Key.down)
  else:
    keyboard.press(Key.down)
    keyboard.release(Key.up)

import sys
options_file_name = sys.argv[1]

import json
from Nose_Tracker import track_face
import pynput
from pynput.keyboard import Key
from pynput.mouse import Button
keyboard = pynput.keyboard.Controller()
mouse = pynput.mouse.Controller()


#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  
  # https://guides.gamepressure.com/southparkgame/guide.asp?ID=24247

  # Nose is left joystick
  if nose_x > 0.5:
    keyboard.press(Key.left)
  else:
    keyboard.release(Key.left)
  if nose_x < -0.5:
    keyboard.press(Key.right)
  else:
    keyboard.release(Key.right)

  if nose_y > 0.5:
    keyboard.press(Key.up)
  else:
    keyboard.release(Key.up)
  if nose_y < -0.5:
    keyboard.press(Key.down)
  else:
    keyboard.release(Key.down)
  
  
  # Mouth Right or Left to trigger A or B buttons
  if mouth_x > 0.9:
    mouse.press(Button.left)
  else:
    mouse.release(Button.left)
  if mouth_x < -0.9:
    keyboard.press('w')
  else:
    keyboard.release('w')

  

#################
# IMPORT OPTIONS #
#################
options_file = open(options_file_name) # Opening JSON file
options = json.load(options_file) # returns JSON object as a dictionary
options_file.close() # Closing file


#################
# START TRACKING #
#################
track_face(logic, options)

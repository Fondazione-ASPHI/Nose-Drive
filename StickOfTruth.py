############################
# You can EDIT the following values
############################

options_file_name = "options.json"



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

import json
from Nose_Tracker import track_face
from pynput.keyboard import Key, Controller
import pyautogui


#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  
  # https://guides.gamepressure.com/southparkgame/guide.asp?ID=24247

  # Nose is left joystick
  if nose_x > 0.5:
    controller.press(Key.left)
  else:
    controller.release(Key.left)
  if nose_x < -0.5:
    controller.press(Key.right)
  else:
    controller.release(Key.right)

  if nose_y > 0.5:
    controller.press(Key.up)
  else:
    controller.release(Key.up)
  if nose_y < -0.5:
    controller.press(Key.down)
  else:
    controller.release(Key.down)
  
  
  # Mouth Right or Left to trigger A or B buttons
  if mouth_x > 0.9:
    pyautogui.click(button='left')  
  if mouth_x < -0.9:
    controller.press('w')
  else:
    controller.release('w')

  

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

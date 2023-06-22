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
  

  # if trigger_mouth_open:
  #   keyboard.press("b")
  # else:
  #   keyboard.release("b")

  # Left Right Arrows
  if nose_x < -0.5:
    keyboard.press(Key.space)
  else:
    keyboard.release(Key.space)
  if nose_x > 0.5:
    keyboard.press(Key.space)
  else:
    keyboard.release(Key.space)

  # Up Down Arrows
  if nose_y < -0.5:
    keyboard.press(Key.space)
  else:
    keyboard.release(Key.space)
  if nose_y > 0.5:
    keyboard.press(Key.space)
  else:
    keyboard.release(Key.space)

  # # Mouth Right or Left
  # if mouth_x > 0.9:
  #   keyboard.press("q")
  # else:
  #   keyboard.release("q")
  # if mouth_x < -0.9:
  #   keyboard.press("e")
  # else:
  #   keyboard.release("e")

  # Head Tilt
  # if head_tilt > 0.9:
  #   gamepad.left_trigger_float(value_float=1)
  # else:
  #   gamepad.left_trigger_float(value_float=0)
  # if head_tilt < -0.9:
  #   gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X)
  # else:
  #   gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_X)
    
  # Eyebrows
  # if trigger_eyebrows:
  #   gamepad.right_trigger_float(value_float=1)
  # else:
  #   gamepad.right_trigger_float(value_float=0)



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

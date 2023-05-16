############################
# You can EDIT the following values
############################

options_file_name = "options.json"



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

import json
from Nose_Tracker import track_face

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()

# Init Keyboard and Mouse inputs simulator
import pynput
from pynput.keyboard import Key
from pynput.mouse import Button
keyboard = pynput.keyboard.Controller()
mouse = pynput.mouse.Controller()


#################
# CUSTOM LOGIC #
#################
mouse_left_down = False

def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  
  # Move forward backward with Vertical Nose
  gamepad.left_joystick_float(x_value_float=0, y_value_float=nose_y)  

  # Rotate Right-Left with Horizontal Nose
  # Mouth Right or Left  
  mx = 0
  if mouth_x > 0.9:
    mx = 0.75
  elif mouth_x < -0.9:
    mx = -0.75
  else:
    mx = 0
  gamepad.right_joystick_float(x_value_float=-nose_x, y_value_float=mx)

  # Eyebrows
  if trigger_eyebrows and not mouse_left_down:
    mouse.press(Button.left)
    mouse_left_down = True
  elif mouse_left_down:
    mouse.release(Button.left)
    mouse_left_down = False


  # Update gamepad
  gamepad.update()
  gamepad.reset()




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

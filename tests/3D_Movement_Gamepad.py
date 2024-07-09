####
# THIS SCRIPT is aimed at moving a character in 3rd or 1st person videogames such as Skyrim.
# Nose up down moves the character, Nose right left moves the camera
# The rest is up to vocal commands
# Alternatively you can use the "Head Mouse" script to move camera while moving the character with vocal commands
###

import sys
options_file_name = sys.argv[1]

import json
from nosedrive import track_face
import keyboard as kb

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# CUSTOM LOGIC #
#################
mode = "Move" # or "Aim"

def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  global mode
  x, y = 0, 0

  if kb.is_pressed("8"):
    mode = "Move"
  elif kb.is_pressed("9"):
    mode = "Aim"

  if mode == "Move":
    # Camera with HORIZONTAL NOSE
    if nose_x < -0.2 or nose_x > 0.2: # Left
      gamepad.right_joystick_float(x_value_float=-nose_x, y_value_float=0)

    # Movement with VERTICAL NOSE
    gamepad.left_joystick_float(x_value_float=0, y_value_float=nose_y)

  elif mode == "Aim":    
    if nose_x < -0.2 or nose_x > 0.2: # Left
      x = -nose_x
    if nose_y < -0.2 or nose_y > 0.2: # Right
      y = nose_y
    gamepad.right_joystick_float(x_value_float=x, y_value_float=y)

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

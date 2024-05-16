#####
# THIS SCRIPT moves game camera with horizontal head rotation for games like Baldur's Gate 3
#####


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

  # Rotate Camera Left
  if nose_x < -0.5:
    keyboard.press("e")
  else:
    keyboard.release("e")

  # Rotate Camera Right
  if nose_x > 0.5:
    keyboard.press("q")
  else:
    keyboard.release("q")




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

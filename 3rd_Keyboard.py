import sys
options_file_name = sys.argv[1]

import json
from Nose_Tracker import track_face
import win32api, win32con
import pynput
from pynput.keyboard import Key
keyboard = pynput.keyboard.Controller()


#################
# CUSTOM LOGIC #
#################
w_pressed = False
s_pressed = False
threshold = 0.5
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  global w_pressed, s_pressed, threshold
  
  # Camera with HORIZONTAL NOSE
  x = 0
  speed = 20
  if nose_x < -0.2 or nose_x > 0.2: # Left
    x = -nose_x*speed
  win32api.mouse_event(win32con.MOUSEEVENTF_MOVE, int(x), 0, 0, 0)

  # Movement with VERTICAL NOSE
  if nose_y > threshold and not w_pressed:
    keyboard.press("w")
    w_pressed = True
  elif nose_y < -threshold and not s_pressed:
    keyboard.press("s")
    s_pressed = True
  elif nose_y < threshold and w_pressed:
    keyboard.release("w")
    w_pressed = False
  elif nose_y > -threshold and s_pressed:
    keyboard.release("s")
    s_pressed = False




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

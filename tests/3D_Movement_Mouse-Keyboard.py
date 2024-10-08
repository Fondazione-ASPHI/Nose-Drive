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
import win32api, win32con
import keyboard as kb
import pynput
from pynput.keyboard import Key
keyboard = pynput.keyboard.Controller()


#################
# CUSTOM LOGIC #
#################
w_pressed = False
s_pressed = False
threshold = 0.5
mode = "Move" # or "Aim"

def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  
  global w_pressed, s_pressed, threshold, mode  
  x, y = 0, 0
  speed = 30

  if kb.is_pressed("8"):
    mode = "Move"
  elif kb.is_pressed("9"):
    mode = "Aim"

  if mode == "Move":
    # Camera with HORIZONTAL NOSE
    if nose_x < -0.2 or nose_x > 0.2: # Left
      x = nose_x*speed
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

  elif mode == "Aim":    
    if nose_x < -0.2 or nose_x > 0.2: # Left
      x = nose_x*speed
    if nose_y < -0.2 or nose_y > 0.2: # Right
      y = nose_y*speed
    win32api.mouse_event(win32con.MOUSEEVENTF_MOVE, int(x), int(y), 0, 0)



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

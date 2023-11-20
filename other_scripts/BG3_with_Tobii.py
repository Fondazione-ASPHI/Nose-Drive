############################
# You can EDIT the following values
############################

options_file_name = "default_settings.json"



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

import json
from Nose_Tracker import track_face
import pyautogui
import time
import keyboard as kb
import numpy as np

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


import keyboard


#################
# CUSTOM LOGIC #
#################
def logic(nose_x, nose_y, mouth_x, head_tilt, trigger_eyebrows, trigger_mouth_open):  

  if trigger_eyebrows:
      pyautogui.mouseDown(button='left')
      pyautogui.mouseUp(button='left')
# Inizializza il rilevatore del movimento della testa
  if nose_x>= 1:
    #pyautogui.mouseDown(button='center')
    kb.press('e')
  else:
    kb.release('e')

  if nose_x<=-1:
    kb.press('q')
  else:
    kb.release('q')


#################
# IMPORT OPTIONS #
#################
options_file = open(options_file_name) # Opening JSON file
options = json.load(options_file) # returns JSON object as a dictionary
options_file.close() # Closing fil


#################
# START TRACKING #
#################
track_face(logic, options)

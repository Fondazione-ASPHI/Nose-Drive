############################
# You can EDIT the following values
############################

nose_horizontal_sensibility = 15 # suggested values between 0 and 30
nose_vertical_sensibility = 30 # suggested values between 0 and 30

use_shoulders = True # set this to True or False whether you want to track the shoulders or not
shoulders_sensibility = 0.05 # suggested values between 0.02 and 0.07

calibration_time = 5 # in seconds



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

from Nose_Tracker import track_nose


# Init Keyboard controller
import keyboard as board
from pynput.keyboard import Key, Controller
from pynput import keyboard
controller = Controller()

# Init Mouse controller
import pyautogui
pyautogui.FAILSAFE = False
width, height = pyautogui.size()
print("Screen resolution:", width, "x", height)


#################
# NOSE #
#################
def nose(x, y):  
  if  (y > 0.5):
    controller.press('w')
  else:
    controller.release('w')  
  if (y < -0.5):
    controller.press('s')
  else:
    controller.release('s')

  if (x > 0.5):
    pyautogui.move(-50, 0)
  elif (x < -0.5):
    pyautogui.move(50, 0)

  
        

#################
# SHOULDERS #
#################
def shoulders(trigger_left, trigger_right):
  if trigger_left:
    pyautogui.click(button='left')
  elif trigger_right:
    pyautogui.click(button='right')



###############################
###############################
###############################

track_nose(
  nose,
  shoulders,
  nose_horizontal_sensibility,
  nose_vertical_sensibility,
  use_shoulders,
  shoulders_sensibility,
  calibration_time
)
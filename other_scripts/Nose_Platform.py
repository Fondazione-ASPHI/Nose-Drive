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


#################
# NOSE #
#################
def nose(x, y):

  if (x > 0.5):
    controller.press(Key.left)
  else:
    controller.release(Key.left)            
  
  if (x < -0.5):
    controller.press(Key.right)
  else:
    controller.release(Key.right)
  
  if  (y > 0.5):
    controller.press(Key.down)
  else:
    controller.release(Key.down)
  
  if (y < -0.5):
    controller.press(Key.up)
  else:
    controller.release(Key.up)
        

#################
# SHOULDERS #
#################
def shoulders(trigger_left, trigger_right):
  if trigger_left:
    controller.press(Key.ctrl) # press Keyboard LEFT ARROW
  else:
    controller.release(Key.ctrl) # release Keyboard LEFT ARROW

  if trigger_right:
    controller.press(Key.alt) # press Keyboard RIGHT ARROW
  else:
    controller.release(Key.alt) # release Keyboard RIGHT ARROW



###############################
###############################
###############################

track_pose(
  nose,
  shoulders,
  nose_horizontal_sensibility,
  nose_vertical_sensibility,
  use_shoulders,
  shoulders_sensibility,
  calibration_time
)
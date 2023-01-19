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

# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# NOSE #
#################
def nose(x, y):  
  gamepad.left_joystick_float(x_value_float=0, y_value_float=y)
  gamepad.right_joystick_float(x_value_float=-x, y_value_float=0)
  gamepad.update()
  gamepad.reset()
  
        

#################
# SHOULDERS #
#################
def shoulders(trigger_left, trigger_right):
  if (trigger_left):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A button        

  if (trigger_right):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)  # Xbox360 B Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)  # Xbox360 B button



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
############################
# You can EDIT the following values
############################

nose_horizontal_sensibility = 15 # suggested values between 0 and 30
nose_vertical_sensibility = 8 # suggested values between 0 and 30

mouth_horizontal_sensibility = 50 # suggested values between 0 and 30
mouth_vertical_sensibility = 50 # suggested values between 0 and 30

eyebrows_sensibility = 0.01

calibration_time = 5 # in seconds



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

from Nose_Tracker import track_face


# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# BUTTONS #
#################
def nose(x, y):  
  gamepad.left_joystick_float(x_value_float=0, y_value_float=y)
  gamepad.right_joystick_float(x_value_float=-x, y_value_float=0)


def mouth(x, y):
  if (x > 0.5):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_A)  # Xbox360 A button
  
  if (x < -0.5):
    gamepad.press_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)  # Xbox360 B Button
  else:
    gamepad.release_button(button=vg.XUSB_BUTTON.XUSB_GAMEPAD_B)  # Xbox360 B button

  # gamepad.right_joystick_float(y_value_float=y)


def eyebrows(trigger_eyebrows):
  if (trigger_eyebrows):
    gamepad.right_trigger_float(value_float=1)
  else:
    gamepad.right_trigger_float(value_float=0)


def endframe():
  gamepad.update()
  gamepad.reset()


###############################
###############################
###############################

options = {
  "nose logic": nose,
  "mouth logic": mouth,
  "eyebrows logic": eyebrows,
  "end frame logic": endframe,
  "nose horizontal sensibility": nose_horizontal_sensibility,
  "nose vertical sensibility": nose_vertical_sensibility,
  "mouth horizontal sensibility": mouth_horizontal_sensibility,
  "mouth vertical sensibility": mouth_vertical_sensibility,
  "eyebrows sensibility": eyebrows_sensibility,
  "calibration time": calibration_time
}


track_face(options)
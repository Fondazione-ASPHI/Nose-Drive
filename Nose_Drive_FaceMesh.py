############################
# You can EDIT the following values
############################

nose_horizontal_sensibility = 15 # suggested values between 0 and 30
nose_vertical_sensibility = 30 # suggested values between 0 and 30

calibration_time = 5 # in seconds



############################
# DON'T EDIT BELOW THIS LINE (unless you know what you are doing)
############################

from Nose_Tracker import track_face


# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()


#################
# NOSE #
#################
def nose(x, y):
  gamepad.left_joystick_float(x_value_float=-x, y_value_float=0)
  if y > 0:
    # controller.release(Key.down)
    gamepad.right_trigger_float(value_float=y)
  elif y < 0:
    # controller.press(Key.down)
    gamepad.left_trigger_float(value_float=1) # value_float=-y if you want analog brake
  gamepad.update()
  gamepad.reset()


###############################
###############################
###############################

options = {
  "nose logic": nose,
  "mouth logic": None,
  "frame end logic": None,
  "nose horizontal sensibility": nose_horizontal_sensibility,
  "nose vertical sensibility": nose_vertical_sensibility,
  "mouth horizontal sensibility": None,
  "mouth vertical sensibility": None,
  "calibration time": calibration_time
}

track_face(options)
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
def logic(nose_x, nose_y, mouth_x, mouth_y, trigger_eyebrows, trigger_mouth_open):
  gamepad.left_joystick_float(x_value_float=-nose_x, y_value_float=0)
  if nose_y > 0:
    # controller.release(Key.down)
    gamepad.right_trigger_float(value_float=nose_y)
  elif nose_y < 0:
    # controller.press(Key.down)
    gamepad.left_trigger_float(value_float=1) # value_float=-y if you want analog brake
  gamepad.update()
  gamepad.reset()


###############################
###############################
###############################

options = {
  "logic": logic,
  "nose horizontal sensibility": nose_horizontal_sensibility,
  "nose vertical sensibility": nose_vertical_sensibility,
  "calibration time": calibration_time
}

track_face(options)
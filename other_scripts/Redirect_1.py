# Init Gamepad controller
import vgamepad as vg # https://pypi.org/project/vgamepad/   https://github.com/ViGEm/ViGEmBus
gamepad = vg.VX360Gamepad()
import keyboard


#################
# CUSTOM LOGIC #
#################
while True:

  # Convert KEYBOARD to Controller (for Vocal Commands)
  if keyboard.is_pressed('space'):
    gamepad.right_trigger_float(value_float=1)
    gamepad.left_trigger_float(value_float=0)
  else:
    gamepad.left_trigger_float(value_float=1)
    gamepad.right_trigger_float(value_float=0)


  # Update gamepad
  gamepad.update()
  gamepad.reset()

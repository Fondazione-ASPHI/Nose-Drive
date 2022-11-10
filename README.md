# Pose Buttons #
Simulate Xbox360 controller inputs using [Mediapipe Pose](https://google.github.io/mediapipe/solutions/pose.html) tracking of Nose and Shoulders joints.

AUTHORS: [Fondazione ASPHI Onlus](https://asphi.it/)

## Demo video ##
[![YouTube sample video](https://img.youtube.com/vi/r1LHRb9G_eM/0.jpg)](https://www.youtube.com/watch?v=r1LHRb9G_eM)

## Setup Instructions ##
* Install the [ViGEmBus driver](https://github.com/ViGEm/ViGEmBus/releases)
* Download and extract our [latest release ZIP file](https://github.com/Fondazione-ASPHI/Nose-Drive/releases)
* Double click on the "START.bat" file
* Wait for your webcam image to show up
* Standing still in front of the webcam, press Q to start giving inputs

## Inputs
Core commands:
* NOSE DOWN: gamepad analog Right-Trigger (accelerator)
* NOSE UP: non-analog keyboard Down Arrow (brake)
* NOSE RIGHT and LEFT: gamepad Left Analog Horizontal Axis (steer left and right)

Optionally:
* RIGHT SHOULDER UP: press gamepad Button A
* LEFT SHOULDER UP: press gamepad Button B (could be handbrake)

## Advanced customization ##
The software and its releases are plain python code that can be modified if you know how to :)

Sensibility for nose and shoulders can be modified in the first two line of the [Buttons.py](https://github.com/Fondazione-ASPHI/Nose-Drive/blob/main/Buttons.py) file.

In the same file you can deactivate/activate shoulders inputs by commenting/decommenting the relevant portion of code.

## Mediapipe Pose Documentation ##
[Python API examples](https://google.github.io/mediapipe/solutions/pose#python-solution-api)

## Videogames Controller ##
### Driver ###
[Driver to Emulate Xbox360 Controller](https://github.com/ViGEm/ViGEmBus/releases)
### Python Libraries ###
* Simulate Xbox360 Controller inputs: [vgamepad](https://pypi.org/project/vgamepad/)
* Read keyboard inputs: [keyboard](https://github.com/boppreh/keyboard#api)
* Simulate keyboard inputs: [pynput](https://pypi.org/project/pynput/)

# Credits #
A big "Thank you!" goes to
* the authors of [ViGEmBus](https://github.com/ViGEm/ViGEmBus) driver
* the authors of [Mediapipe Pose](https://google.github.io/mediapipe/solutions/pose.html) high-fidelity body pose tracking solution
* the authors of [vgamepad](https://pypi.org/project/vgamepad/) python library
* the authors of [keyboard](https://github.com/boppreh/keyboard) python library
* the authors of [pynput](https://pypi.org/project/pynput/) python library

on which our solution relies

# Nose Drive #
Simulate Xbox360 controller inputs using [Mediapipe Pose](https://google.github.io/mediapipe/solutions/pose.html) tracking of Nose and Shoulders joints.

AUTHORS: [Fondazione ASPHI Onlus](https://asphi.it/)

## Demo video ##
[![YouTube sample video](https://img.youtube.com/vi/r1LHRb9G_eM/0.jpg)](https://www.youtube.com/watch?v=r1LHRb9G_eM)

## Setup Instructions ##
* Install the [ViGEmBus driver](https://github.com/ViGEm/ViGEmBus/releases)
* Download and extract our [latest release ZIP file](https://github.com/Fondazione-ASPHI/Nose-Drive/releases)
* Double click on the "START.bat" file
* Wait for your webcam image to show up
* Stand still in front of the webcam in your base position for 5 seconds (can be edited)
* Start playing your games

## Inputs
Core commands:
* NOSE DOWN: gamepad analog Right-Trigger (accelerator)
* NOSE UP: gamepad Left-Trigger (brake)
* NOSE RIGHT and LEFT: gamepad Left Analog Horizontal Axis (steer left and right)

Optionally:
* RIGHT SHOULDER UP: press gamepad Button A
* LEFT SHOULDER UP: press gamepad Button B (could be handbrake)

## Advanced customization ##
The software and its releases are plain python code that can be modified.

In the first lines of the [Nose_Drive.py](https://github.com/Fondazione-ASPHI/Nose-Drive/blob/main/Nose_Drive.py) file you can modify:
* sensibility values for nose horizontal and vertical inputs
* whether to use shoulders or not
* sensibility value for shoulders input
* how many seconds to wait, after the webcam image shows up, before the program takes your actual position as the base position (the pressure of the keys is based on the deviation from this base position)

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

on whose work our solution relies

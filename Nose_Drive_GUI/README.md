# Packaging instructions
The contento of this folder is meant to be edited and built with Visual Studio (last version used: 2022 community).

The following files must be put in the same directory alongside the "release" binaries built with Visual Studio, before packaging everything together with NSIS (the .nsi file can be found in the root directory of the repo):

* The python_310 folder containing Python 3.10 embedded
* A file named to_build.py
* The Builder.spec file, targetting to_build.py
* The custom.py script
* The "dist" folder with compiled "Embedded_Logics" inside
* logic.json
* settings.json

# VRMobile

# How to set up

First of all, you need Unity to build this project, and make sure the Android or IOS build support component is installed. If not, go to File -> Build Setting and install the platform. (The version of it should be 2019.4.4)
 
### Important: This project is an online conference, so there need to be two people to start the session. Therefore, secondary device is required to see the whole project.

Configure settings - Google Developers. (n.d.)

Because the project is built for mobile device, you need to configure the project follow the steps bellow:

## a. Android:
Select File -> Build Setting -> Player Setting

Setting | Value
------------ | -------------
Player Settings > XR Settings > Virtual Reality Supported | Enabled
Player Settings > XR Settings > Virtual Reality SDKs | Click + and select Cardboard
Player Settings > Other Settings > Minimum API Level | Android 4.4 'KitKat' (API level 19) or higher

## b. IOS
Select File -> Build Setting -> Player Setting

Setting | Value
------------ | -------------
Player Settings > Other Settings > Virtual Reality Supported | Enabled
Player Settings > Other Settings > SDKs | Click + and select Cardboard
Player Settings > Other Settings > Target minimum iOS version | 8.0 or higher
Player Settings > Other Settings > Bundle Identifier | Follow reverse the DNS format suggested by Apple

# Preview the Scene in Unity

1.	In Unity Project window, go to Scenes -> Scenes Main Menu
2.	Press Play button, in the Game view you should see the name input textbox.
3.	Press Continue button, and you can see “Waiting for other people”
4.	Second device needed to keep going.

# Build and run the demo scene on your device - Google Developers. (n.d.)

## a. Android
	1. Enable developer options on your device
	2. Connect your phone to your computer using a USB cable.
	3. Select File > Build and Run.
	Unity builds your project into an Android APK, installs it on the device, and launches it.
	4. Put the phone in your viewer and try out the demo
## b. IOS
	1. Connect your phone to your computer using a USB cable.
	2. Select File > Build and Run.
	Unity builds your project and opens the generated XCode workspace.
	3. Put the phone in your viewer and try out the demo

# How to control in Unity Editor play mode

Type | Simulated action | What to do
------------ | ------------- | -------------
Head movement | Turn your head | Hold Alt + move mouse
Head movement | Tilt your view | Hold Control + move mouse
Teleport | Button press | Hold Alt + move mouse + mouse click

# Reference
Google Developers. (n.d.). QuickStart for Google VR SDK for Unity with Android. [online] Available at: https://developers.google.com/vr/develop/unity/get-started-android

## Contribution
In Submmission folder


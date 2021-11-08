# PlanRadar_Assessment

## What to expect from the app?
#### What will you see?
- At the start you will see the unity logo.
- Then the loading screen followed by another scene, which has the building model and a reset button on the top left, and the frame per second on the top right

#### How will you interact with the app?
- With 2 fingers touch (pinch): you will be able to zoom in and out to/from the center of the building.
- With one finger touch (swiping): you will be able to rotate the building.
- When the “Reset” button is clicked: the whole building will lerp to its initial view in a smooth way.

![building](https://user-images.githubusercontent.com/17506857/140717957-a8412450-07da-4f15-bdd4-9e5ff440bd19.PNG)


Note: This project was tested on editor and on android device only. 

## How to build on an android device?
- The mobile should be connected with the device with a usb.
- Change the choice of “Charge this device” to “Transfer photo (PTP)”, from mobile (android device).

![Options](https://user-images.githubusercontent.com/17506857/140720300-ee5b51ee-4331-4a5e-8f8a-3be659fc0e15.PNG)

- Back to unity editor: From File => Build Settings => click “Build And Run” button

![build](https://user-images.githubusercontent.com/17506857/140719574-2e66adaa-3856-436b-a6f4-d76d03b16ac2.PNG)

Note: You can see in the build settings window that the target platform selected is Android, Because there is a unity logo assigned to it.

- Then name the apk and click “Save”.

![save](https://user-images.githubusercontent.com/17506857/140719902-a1773f82-11e9-4550-8f2c-22b76a2a04ea.PNG)

- After several minutes the app will be opened on your android device by itself.

![loading](https://user-images.githubusercontent.com/17506857/140720652-3f84e89f-17a2-4d32-83c5-d86f07355a31.png)

## How to run the project in editor mode?
- Make sure that the “LoadingScene” is open.
- You could find it here (“Project” window=> Assets=> Scenes=> “LoadingScene”).

![scenes](https://user-images.githubusercontent.com/17506857/140720967-439bcc5c-83a0-4509-aa6f-c7ff8718a30f.PNG)

- Click on the play button

![Play](https://user-images.githubusercontent.com/17506857/140721253-09943c5c-0c30-4f11-bac5-f4b30ebb88fa.PNG)

## How to switch to another platform?
- Select the platform you want.
- Click on the “Switch Platform” button. 

![switch](https://user-images.githubusercontent.com/17506857/140721679-d8245798-1baf-4b6f-81e3-c8313485eff3.PNG)

## Known Issue
The building at some point refuses any gestures (rotating, zooming).

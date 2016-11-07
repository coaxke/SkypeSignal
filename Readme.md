# SkypeSignal



Skype signal is a simple .NET console app and Arduino sketch to build your very own Lync/Skype status light pretty easily

**My solution comprises of two main parts:**

- An Arduino nano connected to a couple of RGB LED lights
- A .NET application which uses the Lync client SDK to send commands to the Arduino via serial (over USB)
 
**The operating workflow:**

- Device connected to USB
- Relevant COM port set in SkypeSignal Config and started on PC
    - A thread is started to run a small tray application on the windows task bar
    - A thread is started to subscribe to Skype/Lync client events using the client SDK
- On client status change a command is sent down to the Arduino where it switches the light to the colour/pattern representing the presence of the user.

Read more here [https://www.resdevops.com/2016/11/07/building-a-skypelync-notification-light](https://www.resdevops.com/2016/11/07/building-a-skypelync-notification-light).

OhShit ! - Escape hardcore POE using a hotkey

This tool will simply execute a command line using a hotkey (hardcoded as CTRL+BACKSPACE). 

This can also be used to call CPORTS.EXE and close all tcp/udp connections on a process (ie: Path of Exile)

How to Configure
Open OhShit.exe.config with notepad
Change the below line to point to where your cports.exe is
<add key="command_line" value="D:\Tools\ohshit\cports.exe" />
Save and Close notepad
Run OhShit as admin
Test that the Tilde Hotkey leaves game
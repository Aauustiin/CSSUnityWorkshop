## Unity Workshop

We will be making our own version of Flappy Bird [(https://en.wikipedia.org/wiki/Flappy_Bird](https://en.wikipedia.org/wiki/Flappy_Bird)) - this task is pretty much the game development equivalent of the “Hello, World” programming exercise. It should equip you with the prerequisite knowledge you will need to create most kinds of games you might want to work on during the upcoming game jam.

Throughout the workshop, I assume that everyone will be using the lab machines. If you aren't, you'll need to go through the instructions here: ([https://unity.com/download](https://unity.com/download)) in order to install the required software on your machine.

### Setup

First, we need to create a project. We will be doing so through the Unity Hub, which is a piece of software that helps you manage your various projects and Unity Editor installations.

1.  Click on the start menu (bottom-left of the screen) and open “Unity Hub”, which is located near to the bottom of the list of applications.
    1.  If Unity Hub buffers endlessly at this point… best to switch to a different machine.
2.  It will prompt you to sign in or create an account with Unity.
    1.  Once you have done so, a popup will appear with the heading “This site is trying to open Unity Hub” - click "Open".
3.  Unity Hub will prompt you to install a Unity editor, select “Locate Existing Installation” and then “C:\\Program Files\\Unity 2022.3.6f1\\Editor\\Unity”
4.  Now go to Projects → New Project → 2D (URP) → “Create Project”
    1.  You may also want to change the project name and install location while creating the project. You'll find the options to do so on the RHS of the “New Project" menu.

### The Bird

The beating heart of “Flappy Bird” is the flappy bird. But how can we make an entity which falls just like that thing does? Fortunately, the developers of Unity have already tackled this question for us. They made physics, and we can just attach a few 

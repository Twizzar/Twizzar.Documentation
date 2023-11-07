<script setup lang="ts">
import DocImg from '../components/DocImg.vue'
</script>

# Key bindings

| Command                      | Description                                            | Key binding                                                                              |
| ---------------------------- | ------------------------------------------------------ | ---------------------------------------------------------------------------------------- |
| About                        | Opens the about dialog                                 | <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>N</kbd>,<br> <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>A</kbd> |
| Create UnitTest              | Creates a new unit test for the member under the cursor | <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>N</kbd>,<br> <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>N</kbd> |
| UnitTest <-> Code Navigation | Jumps either to the unit test or the member definition | <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>N</kbd>,<br> <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>G</kbd> |
| Open or close                | Open or close the Twizzar UI                           | <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>N</kbd>,<br> <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>V</kbd> |

## Reset shortcuts

In case you want to reset the twizzar shortcuts, you can do so by opening the about window via the main menu : `Extensions > TWIZZAR > About` or shortcut (<kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>N</kbd>, <kbd>CTRL</kbd>+<kbd>ALT</kbd>+<kbd>A</kbd>).

<DocImg src="../images/Twizzar_Reset_Shortcuts.png" alt="Reset the shortcuts to the default configuration in the about window."/>

On the about window you can find a button "Set default shortcut binding", in the center of the window. By clicking the button all shortcut bindings, using the twizzar key-combinations, are removed and reassigned to the twizzar commands.

## Define shortcuts

Custom shortcuts for the Twizzar commands can be assigned via the build-in options window of Visual Studio: `Main Menu > Tools > Options`

<DocImg src="../images/Twizzar_Set_Shortcuts.png" alt="Open the options window of Visual Studio to set the TWIZZAR shortcuts."/>

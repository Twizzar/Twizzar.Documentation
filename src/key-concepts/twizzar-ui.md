<script setup lang="ts">
import DocImg from '../../components/DocImg.vue'
</script>

# Twizzar UI

For easy configuration, the Twizzar UI can be used. To open it use the arrow behind the ItemBuilder or use the Twizzar open/close shortcut (<kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>N</kbd>, <kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>V</kbd>).

<DocImg src="../images/Twizzar_Expand_Button.png" alt="Twizzar expand button, to open the UI"/>

The Twizzar UI has three columns.
<DocImg src="../../images/Twizzar_UI_Potion.png" alt="Twizzar UI"/>
The Twizzar UI shows all configurable members in the first column, an input field to configure the members in the second column and the type of the member in the third column. To navigate the UI, use the arrow keys and open or close sub member by the Twizzar open/close shortcut (<kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>N</kbd>, <kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>V</kbd>). To close the UI press <kbd>ESC</kbd>.

To configure a [basic type](./basic-types), a value can be entered:

- for string, enter the text surrounded by `"` ("Mana Potion")
- for char enter a character surrounded by `'` ('a')
- for numeric types, simply enter a number (5.6)
- for enums type the enum class and then the enum value separated by a `.` (`PotionColor.Blue`)

<DocImg src="../../images/Twizzar_UI_Basic_Types.png" alt="Showcase of some basic types."/>

Non-basic type can be expanded, and their member can be configured directly.
<DocImg src="../../images/Twizzar_UI_Non_Basic_Types.png" alt="Showcase of some non-basic types."/>

It is also possible to change the resolved type, by opening the autocomplete with <kbd>CTRL</kbd> + <kbd>Space</kbd> and selecting a different type.
<DocImg src="../../images/Twizzar_UI_Change_Type.png" alt="Change the type of a member."/>

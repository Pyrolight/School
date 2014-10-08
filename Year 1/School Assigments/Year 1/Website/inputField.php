<?php
function inputDiv($divFormat, $inputLabel, $inputType, $inputClass, $inputID, $inputValue, $divJS, $fieldActive) {
    echo "<div class=\"row\">\n";
    for ($rowOne = 0; $rowOne < count($inputID); $rowOne++) {
        echo "<div class=\"$divFormat\">\n";
        echo "<label>$inputLabel[$rowOne]</label>\n";
        echo "<input type=\"$inputType\" class=\"$inputClass\" id=\"$inputID[$rowOne]\" name=\"$inputID[$rowOne]\" value=\"$inputValue[$rowOne]\"" . $divJS[$rowOne] . $fieldActive . "/>\n</div>\n";
    }
    echo "</div>";
}
?>
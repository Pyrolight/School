<?php

/**
 * @author Michael Fesser
 * @since 5/4/2014
 * 
 * This class is used to create a HTML button.
 */

class Button{
    
    // These fields hold the buttons properties. They are set to private for data hiding.
    private $type;
    private $class;
    private $name;
    private $id; 
    private $value;

    /**
     * 
     * This constructor is used to create and set all the button properties.  The values
     * are passed into this construction when the button is created ie $button = new Button($attributes)
     * and then the fields are set within the class with $this->$attribute.
     * 
     * @param type $type
     * @param type $class
     * @param type $name
     * @param type $id
     * @param type $value
     */
    function __construct($type, $class, $name, $id, $value) {
        $this->type = $type;
        $this->class = $class;
        $this->name = $name;
        $this->id = $id;
        $this->value = $value;
    }
    
    /**
     * This function generates the button with it's HTML properties.  It uses the 
     * classes fields to set the properties of the button.
     */
    function makeButton(){
        echo "<input type= '$this->type' class = '$this->class' name = '$this->name' id = '$this->id' value = '$this->value' />" ;
    }        
}
?>
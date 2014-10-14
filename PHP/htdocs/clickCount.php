<!DOCTYPE html>
<html>
    <body>
        <?php

        /*
        author: Eric coffin
        name: clickCount.php
        description:

        Using the hidden field named clickCount,
        we keep track of clickCount.
        The first time the form loads, the user did
        not click submit, thus we execute the else clause
        of the select statement.  Thus we start with
        $clickCount = 0, and we print that value in
        the value attribute of the hidden field named clickCount.

        If the form was submitted, the form input named
        submit will exist, and we go ahead and extract
        the clickCount variable from POST; increment it,
        and then go ahead and print the form again with
        the hidden field storing the incremented clickCount.


        */

        if(isset($_POST['submit']) == true ) {

            $clickCount = intval($_POST['clickCount']);
            $clickCount += 1;

        }
        else {
            $clickCount = 0;
        }

        ?>

    <form method="POST" action="clickCount.php">

        <input type="hidden" name="clickCount" value="<?php echo $clickCount; ?>" />
        <input type="submit" value="Click" name="submit" />
    </form>


    <h3>You have submitted this form <?php echo $clickCount; ?> times.</h3>


</body>
</html>
<?php
	//Don Bowers
	//Demo simple login script
	//Sept 29, 2014

?>
<!DOCTYPE html>
<html>
	<head>
		<title>Simple Login Idea</title>
	</head>
	<body>

		<form action="login.php" method="post">
			username <input type="text" name="user" /><br />
			password <input type="text" name="pass" /><br />
			<input type="submit" value="Login" />
		</form>

			<?php

				if(isset($_POST['user']) && isset($_POST['pass'])) {


					$mysqli = new mysqli("localhost","db2288_user","db2288_password","DB2288");

					if ( $mysqli->connect_error ) {
						die('Connect error ('. $mysqli->connect_errno .') '
						. $mysqli->connect_error);
					}

							$user = $mysqli->real_escape_string($_POST['user']);
							$pass = $mysqli->real_escape_string($_POST['pass']);

					$query = "select count(*) from users where username='".$user."' and password=sha1('".$pass."')";
					$result = $mysqli->query($query);

					$row = $result->fetch_row();

					if ( $row[0] == 1 ) {
						echo "User exists";
					}
					else
					{
						echo "Error!";
					}


					$mysqli->close();
				}
			?>
	</body>
</html>
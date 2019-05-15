<html>
<body>
<?php
include 'secrethelper.php';

    echo 'Secret-Sample ' . date("d.m.Y H:i:s") . '<br/> ';

    $databaseconfig = SecretHelper::GetSecret('databaseconfig.cfg');
    if($databaseconfig == '')
    {
        echo 'Es wurde keine databaseconfig gefunden';
    }
    else
    {
        echo 'databaseconfig: ' . $databaseconfig;
    }
?>
<body>
<html>
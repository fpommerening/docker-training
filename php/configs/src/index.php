<html>
<body>
<?php
    $filename = './appsettings.json';
    $cfgContent = file_get_contents($filename, true);
    $cfg = json_decode($cfgContent);
    echo 'Config-Sample ' . date("d.m.Y H:i:s") . '<br/> ' . $cfg->{'greeting'};
?>
<body>
<html>
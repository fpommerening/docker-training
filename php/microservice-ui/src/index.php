<?php
    require 'vendor/autoload.php';
?>
<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Microservice - Dashboard</title>
</head>
<body>
    <h3>Microservice Dashboard</h3>
<br />
<div style="width: 300px; height: 200px; border-color: black; border-style: dotted; display: inline-block; margin: 20px;padding: 10px">
    <span style="alignment: center; font-weight: bolder">Time Service</span>
    <br />
    <br />
    <?php
    $timeinfoUri = getenv('TimeUrl');
    $timeinfo = null;
    if($timeinfoUri != null && $timeinfoUri != '')
    {
        $timeinfo = \Httpful\Request::get($timeinfoUri)->send();
    }

    echo 'Time: ' .$timeinfo->body->datetime . '<br />';
    echo 'Host: ' .$timeinfo->body->hostname . '<br />';
    echo 'Language: ' .$timeinfo->body->lang . '<br />';

    ?>

</div>
<div style="width: 300px; height: 200px; border-color: black; border-style: dotted; display: inline-block;margin: 20px;padding: 10px">
    <span style="alignment: center;font-weight: bolder">PingMe Service</span>
    <br />
    <br />
    <?php
    $pingMeUri = getenv('PingMeUrl');
    $pingMe = null;
    if($pingMeUri != null && $pingMeUri != '')
    {
        $pingMe = \Httpful\Request::get($pingMeUri)->send();
    }
    echo 'Last: ' . $pingMe->body->last . '<br />';
    echo 'Kind: ' . $pingMe->body->kind .'<br />';
    echo 'Language: ' . $pingMe->body->lang . '<br />';
    ?>
</div>

<br />
<br />
<?php
    echo 'Current-UI: ' . date("d.m.Y H:i:s");
?>
</body>
</html>
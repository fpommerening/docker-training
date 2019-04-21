<?php

include 'timeinfo.php';

header_remove();
header('Content-Type: application/json');
header('Status: 200');

$info = new TimeInfo();
echo json_encode($info);


?>
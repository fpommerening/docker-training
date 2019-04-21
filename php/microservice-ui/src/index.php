<?php
require 'vendor/autoload.php';

$uri = "https://reqres.in/api/users/2";
$response = \Httpful\Request::get($uri)->send();
 
echo 'The test user named ' . $response->body->data->first_name. ".\n";


?>
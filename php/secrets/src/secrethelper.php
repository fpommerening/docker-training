<?php

class SecretHelper
{
    protected static $defaultpath = '/run/secrets/';

    public static function GetSecret($secretname)
    {
        $filename = self::$defaultpath . $secretname;
        if(file_exists($filename))
        {
            return file_get_contents($filename, true);
        }
        return '';
    }
}
?>

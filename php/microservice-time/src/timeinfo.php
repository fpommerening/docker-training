<?php

class TimeInfo implements JsonSerializable {
    protected $hostname;
    protected $datetime;

    public function __construct()
    {
        $this->hostname = gethostname();
        $this->datetime = new DateTime();
    }

    public function getHostname() 
    {
        return $this->hostname;
    }
    
    public function getDateTime() 
    {
        return $this->datetime;
    }

    public function jsonSerialize()
    {
        return 
        [
            'hostname' => $this->getHostname(),
            'lang' => 'php',
            'datetime' => $this->getDateTime()->format(DateTimeInterface::W3C)
        ];
    }
}
?>
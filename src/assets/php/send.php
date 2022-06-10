<?php
    $email = $_POST['email'];
    $message = $_POST['message'];
    
    $error = '';
    if(trim($email) == '')
        $error = "Enter your email";
    else if(trim($message) == '')
        $error = 'Enter your message';
    else if(strlen($message) < 10)
        $error = 'Message must be more than 10 characters';

    if($error != '') {
        echo $error;
        exit;
    }

    $subject = "=?utf-8?B?".base64_encode("send")."?=";

    $headers = "From: $email\r\nReply-to: $email\r\nContent-type: text/html;charset=utf=8\r\n";
    
    mail('official.FastMachanism@gamil.com', $subject, $message, $headers);
?>
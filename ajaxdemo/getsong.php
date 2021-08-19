<?php
    $song1 = array ('id'=>1, 'artist'=>'ABBA', 'title'=>'Dancing Queen');
    $song2 = array ('id'=>2, 'artist'=>'Alan Walker', 'title'=>'song 1');
    $song3 = array ('id'=>3, 'artist'=>'Shakira', 'title'=>'song 2');
    $song4 = array ('id'=>4, 'artist'=>'Rihhana', 'title'=>'song 3');
    $arr_list = [$song1, $song2, $song3, $song4];
    header('Content-type: application/json');
    echo json_encode($arr_list);
?>
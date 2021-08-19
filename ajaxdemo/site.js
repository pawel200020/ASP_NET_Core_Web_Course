$(function () {
    console.log("jquery is running. Doc is ready.");

    $("#get-songs-from-api").click(function () {
        console.log("clicked");
        $.ajax({
            dataType: "Json",
            url: "getsong.php",
            success: function (songs) {
                console.log("data recived");
                console.log(songs);
                $.each(songs, function (i, song) {
                    var songString = '<li>Title: ' + song.title + ' Artist: ' + song.artist + '</li>';
                    $(songString).appendTo("#songs").hide().fadeIn(2000);
                });
            },
        });
    });

    $("#add-song").click(function () {
        console.log("clicked");
        var song = {
            title: $("#title").val(),
            artist: $("#artist").val()
        };
        
        $.ajax({
            type: "GET",
            dataType: "Json",
            data: song,
            url: "putsong.php",
            success: function (newsong) {
                console.log("data recived one song");
                console.log(newsong);
                var songString = '<li>Title: ' + newsong.title + ' Artist: ' + newsong.artist + '</li>';
                $(songString).appendTo("#songs").hide().fadeIn(2000);
            },
        });
    });
});
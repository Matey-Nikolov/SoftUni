function gramophone(band, album, song) {
    let bandNameLength = band.length;
    let albumLength = album.length;
    let songLength = song.length;

    let songDuration = (albumLength * bandNameLength) * songLength / 2;
    let rotation = Math.ceil(songDuration / 2.5);

    console.log(`The plate was rotated ${rotation} times.`);
}

gramophone('Black Sabbath', 'Paranoid', 'War Pigs');
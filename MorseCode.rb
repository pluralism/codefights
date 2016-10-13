$morseCode = {
  "._"=>'A',
  "_..."=>'B',
  "_._."=>'C',
  "_.."=>'D',
  "."=>'E',
  ".._."=>'F',
  "__."=>'G',
  "...."=>'H',
  ".."=>'I',
  ".___"=>'J',
  "_._"=>'K',
  "._.."=>'L',
  "__"=>'M',
  "_."=>'N',
  "___"=>'O',
  ".__."=>'P',
  "__._"=>'Q',
  "._."=>'R',
  "..."=>'S',
  "_"=>'T',
  ".._"=>'U',
  "..._"=>'V',
  ".__"=>'W',
  "_.._"=>'X',
  "_.__"=>'Y',
  "__.."=>'Z'
}


def MorseCode(message, key)
  key = key.split(' ').map { |word|
    $morseCode[word]
  }.join


  message = message.split('  ').map { |word| # Split in words
    # Split each word in chars
    word.split(' ').map { |letter|
      $morseCode[letter]
    }.join
  }
end

message = "_._. ___ _.. . .._. .. __. .... _ ..."
key = "_._. .._."

MorseCode(message, key)

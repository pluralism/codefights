def caesarian(message, n)
  a = Hash[('a'..'z').to_a.map {|k| [k, ((k.ord - 97 + n) % 26 + 97).chr]} ]
  message.chars.map { |chr| a[chr] }.join
end


caesarian("abc", 3)

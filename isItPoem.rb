def rhyme? a
  return a.collect { |t| t[1] }.map { |n| n[-3..-1] }.uniq.length == 1
end


def isItPoem r, t
  t.each_slice(r.length) { |n|
    tmp = r.zip(n)
    r.uniq.each { |p| return false if !rhyme? tmp.select { |t| t[0] == p } }
  }
  true
end

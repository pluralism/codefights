def StairsGain s
  d, d[0], d[1] = [], 0, s[0] == 'y' ? 1 : -2

  (2..s.length).each do |i|
    t = s[i - 2] == 'y' ? 2 : - 1
    d[i] = s[i - 1] == 'y' ? [d[i - 1] + 1, d[i - 2] + t + 1].max : [d[i - 1] - 2, d[i - 2] + t - 2].max
  end
  d.last
end

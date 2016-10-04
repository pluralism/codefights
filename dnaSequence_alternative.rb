def dnaSequence s
  h, d = Hash.new(0), Hash.new(0)
  d[[0, 0, 0]] = 1

  t = 0
  s.chars.each { |c|
    h[c] += 1
    r = [h['A'] - h['C'], h['C'] - h['G'], h['G'] - h['T']]
    t += d[r]
    d[r] += 1
  }
  t
end

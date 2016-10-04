def dnaSequence s
  h, d = Hash.new(0), Hash.new(0)
  d[[0, 0, 0]] += 1

  s.chars.each { |c|
    h[c] += 1
    r = [h['A'] - h['C'], h['C'] - h['G'], h['G'] - h['T']]
    d[r] += 1
  }
  d.values.map { |n| n * (n - 1) >> 1 }.inject(:+)
end

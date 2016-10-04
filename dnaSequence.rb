def dnaSequence s
  h, d = Hash.new(0), Hash.new(0)
  d[[0, 0, 0]] += 1

  s.chars.each { |c|
    h[c] += 1
    d[[h['A'] - h['C'], h['C'] - h['G'], h['G'] - h['T']]] += 1
  }
  d.values.map { |n| n * (n - 1) >> 1 }.inject(:+)
end

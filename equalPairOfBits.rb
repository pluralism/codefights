def equalPairOfBits(n, m)
  s = (n ^ m).to_s(2)
  i = s.rindex('0')
  return 2 ** s.length if i.nil?
  return 2 ** (s.length - i - 1)
end

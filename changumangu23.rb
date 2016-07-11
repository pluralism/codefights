def changumangu23 n
  0 if n < 2
  w = [0, 0, 1, 1]
  for i in 4..n
      w[i] = (w[i - 3] + w[i - 2]) % (10**9 + 7)
  end
  w[n]
end

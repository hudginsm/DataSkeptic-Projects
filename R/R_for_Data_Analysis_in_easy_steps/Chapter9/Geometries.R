frame <- read.csv("DataSet-ProfSalaries.csv")
library(ggplot2)

ggplot(data=frame, aes(x=rank)) +
  geom_bar(fill="Yellow", color="Red")

ggplot(data=frame, aes(x=salary)) +
  geom_histogram(aes(fill=rank), color="White", bins=20)
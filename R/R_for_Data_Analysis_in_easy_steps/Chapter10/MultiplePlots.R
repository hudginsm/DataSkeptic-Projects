frame <- read.csv("DataSet-Hurricanes.csv")

head(frame, n=8)

library(ggplot2)

ggplot(
  data=frame,
  aes(
    x=Year,
    y=DamageMillions,
    size=DamageMillions,
    color=WindMPH
  )
)

damage_plot <- ggplot(
  data=frame,
  aes(
    x=Year,
    y=DamageMillions,
    size=DamageMillions,
    color=WindMPH
  )
)

damage_plot + geom_point()

damage_plot + geom_point() + geom_line(size=0.5)

damage_plot +
  ggtitle("US Atlantic Hurricanes") +
  xlab("Event Year") +
  ylab("Damage $ Millions") +
  geom_point() +
  geom_line(size=0.5)

damage_plot +
  labs(
    title="US Atlantic Hurricanes",
    subtitle="1950-2012",
    x="Event Year",
    y="Damage $ Millions",
    caption="Source: Wikipedia"
  ) +
  geom_point() +
  geom_line(size=0.5)

label_object <- labs(
  title="US Atlantic Hurricanes",
  subtitle="1950-2012",
  x="Event Year",
  y="Damage $ Millions",
  caption="Source: Wikipedia"
)

damage_plot + label_object +
  geom_point() + geom_line(size=0.5)

theme_object <- theme(
  plot.title = element_text(color="Red", family="Wide Latin"),
  plot.subtitle = element_text(color="Red"),
  axis.title.x = element_text(color="Red", face="bold"),
  axis.title.y = element_text(color="Red", face="bold"),
  plot.caption = element_text(color="Black", face="italic"),
  legend.background = element_rect(color="Gray")
)

damage_plot +
  label_object +
  geom_point() +
  geom_line(size=0.5) +
  theme_object

head(frame, n=8)

gender_plot <- ggplot(
  data=frame,
  aes(
    x=Sex,
    y=Deaths,
    color=Sex
  ),
  size=3
)

gender_plot +
  label_object +
  xlab("Gender") +
  ylab("Number of Fatalities") +
  geom_jitter() +
  geom_boxplot(alpha=0.5)+
  ylim(10,200)+
  theme_object

head(frame, n=8)

fatal_plot <- ggplot(
  data=frame,
  aes(
    x=Year,
    y=Deaths
  )
)

fatal_plot +
  label_object +
  ylab("Number of Fatalities") +
  geom_point(aes(color=WindMPH)) +
  geom_text(
    aes(
      label=ifelse(
          Death > 180,as.character(Name),""
      ),hjust=1.1
    )
  ) +
  geom_smooth() +
  theme_object

windspeed_plot <- ggplot(
  data=frame,
  aes(
    x=Year,
    y=Deaths
  )
)

windspeed_plot +
  label_object +
  ylab("Number of Fatalities") +
  geom_point(
    aes(color=WindMPH),
    size=10,
    shape=17
  ) +
  xlim(1980,2000) +
  ylim(0,65) +
  theme_object

strike_plot <- ggplot(
  data=frame,
  aes(
    x=Year,
    y=Sex
  )
)

strike_plot +
  label_object +
  ylab("Number of Strikes") +
  geom_bar() +
  coord_cartesian(xlim=c(1980,2000)) +
  theme_object

frame.tx <- frame[grep("TX",frame$AffectedStates),]

texas_plot <- ggplot(
  data=frame.tx,
  aes(
    x=Year,
    y=DamageMillions,
    size=Deaths,
    color=AffectedStates
  )
)

texas_plot +
  label_object +
  geom_point(aes(size=Deaths)) +
  facet_grid(AffectedStates~.) +
  theme_object

frame.fl <- frame[grep("FL",frame$AffectedStates),]

florida_plot <- ggplot(
  data=frame.fl,
  aes(x=Year)
)

florida_plot +
  label_object +
  ylab("Number of Strikes in Florida") +
  geom_histogram(
    aes(fill=AffectedStates),
    color="Black",
    bins=20
  ) +
  theme_object
